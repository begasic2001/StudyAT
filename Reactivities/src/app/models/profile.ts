import { User } from "./user";

export interface IProfile {
  userName: string;
  displayName: string;
  image?: string;
  bio?: string;
  photos?: Photo[];
}

export class Profile implements IProfile {
  constructor(user: User) {
    this.userName = user.userName, 
    this.displayName = user.displayName;
    this.image = user.image;
  }

  userName: string;
  displayName: string;
  image?: string;
  bio?: string;
  photos?: Photo[];
}

export interface Photo {
  id: string;
  imageUrl: string;
  isMain: boolean;
}
