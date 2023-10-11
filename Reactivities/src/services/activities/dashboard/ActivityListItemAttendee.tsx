import { List, Image, Popup } from "semantic-ui-react";
import { Profile } from "../../../app/models/profile";
import { Link } from "react-router-dom";
import ProfileCard from "../../profiles/ProfileCard";
interface Props {
  attendees: Profile[];
}
export default function ActivityListItemAttendee({ attendees }: Props) {
  return (
    <List horizontal>
      {attendees.map((a) => (
        <Popup
          hoverable
          key={a.userName}
          trigger={
            <List.Item
              key={a.userName}
              as={Link}
              to={`/profiles/${a.userName}`}
            >
              <Image size="mini" circular src={a.image || "/assets/user.png"} />
            </List.Item>
          }
        >
          <Popup.Content>
            <ProfileCard profile={a} />
          </Popup.Content>
        </Popup>
      ))}
    </List>
  );
}
