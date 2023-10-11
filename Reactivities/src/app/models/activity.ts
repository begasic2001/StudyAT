import { Profile } from "./profile";

export interface IActivity {
  id: string;
  title: string;
  date: Date | null;
  description: string;
  category: string;
  city: string;
  venue: string;
  hostUserName: string;
  isCancelled: boolean;
  isGoing: boolean;
  isHost: boolean;
  host?: Profile;
  attendees?: Profile[];
}

export class Activity implements IActivity{
  constructor(init:ActivityFormValues){
    this.id = init.id!;
    this.title = init.title
    this.date = init.date
    this.description = init.description
    this.category =init.category
    this.city = init.city
    this.venue = init.venue
  }
  id: string;
  title: string;
  date: Date | null;
  description: string;
  category: string;
  city: string;
  venue: string;
  hostUserName: string = '';
  isCancelled: boolean = false;
  isGoing: boolean = false;
  isHost: boolean = false;
  host?: Profile;
  attendees?: Profile[];
}

export class ActivityFormValues {
  id?: string = undefined;
  title: string = "";
  category: string = "";
  description: string = "";
  date: Date | null = null;
  city: string = "";
  venue: string = "";

  constructor(activity?: ActivityFormValues){
    if(activity){
      this.id = activity.id;
      this.title = activity.title
      this.category=activity.category
      this.city = activity.city
      this.date=activity.date
      this.description = activity.description
      this.venue = activity.venue
    }
  } 
}
