import { action,makeObservable, observable} from "mobx";
export default class ActivityStore {
  title = "hello form mobx";

  constructor() {
    makeObservable(this, {
      title: observable,
      setTitle:action
    });
  }

  setTitle = () => {
    this.title = this.title + "!";
  }
}
