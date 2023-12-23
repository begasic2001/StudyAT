import { ChatComment } from "./../models/comment";
import {
  HubConnection,
  HubConnectionBuilder,
  LogLevel,
} from "@microsoft/signalr";
import { makeAutoObservable, runInAction } from "mobx";
import { store } from "./store";

export default class CommentStore {
  comments: ChatComment[] = [];
  hubConnection: HubConnection | null = null;

  constructor() {
    makeAutoObservable(this);
  }

  createHubConnection = (activityId: string) => {
    if (store.activityStore.selectedActivity) {
      this.hubConnection = new HubConnectionBuilder()
        .withUrl(import.meta.env.VITE_CHAT_URL + `?activityId=${activityId}`, {
          accessTokenFactory: () => store.userStore.user?.token! as string,
        })
        .withAutomaticReconnect()
        .configureLogging(LogLevel.Information)
        .build();
    }
    this.hubConnection
      ?.start()
      .catch((err) => console.log(`Error establishing the connection ${err}`));

    this.hubConnection?.on("LoadComments", (comments: ChatComment[]) => {
      runInAction(() => {
        comments.forEach((comment) => {
          comment.createdAt = new Date(comment.createdAt + "Z");
        });
        this.comments = comments;
      });
    });

    this.hubConnection?.on("ReceiveComment", (comment: ChatComment) => {
      runInAction(() => {
        comment.createdAt = new Date(comment.createdAt);
        this.comments.unshift(comment);
      });
    });
  };

  stopHubConnection = () => {
    this.hubConnection?.stop().catch((err) => console.log(err));
  };

  clearComments = () => {
    this.comments = [];
    this.stopHubConnection();
  };

  addComment = async (values: any) => {
    values.activityId = store.activityStore.selectedActivity?.id;
    try {
      await this.hubConnection?.invoke("SendComment", values);
    } catch (error) {
      console.log(error);
    }
  };
}
