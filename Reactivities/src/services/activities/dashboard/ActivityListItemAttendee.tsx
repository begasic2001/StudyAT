import { List, Image } from "semantic-ui-react";
import { Profile } from "../../../app/models/profile";
import { Link } from "react-router-dom";
interface Props {
  attendees: Profile[];
}
export default function ActivityListItemAttendee({ attendees }: Props) {
  return (
    <List horizontal>
      {attendees.map((a) => (
        <List.Item key={a.userName} as={Link} to={`/profiles/${a.userName}`}>
          <Image size="mini" circular src={a.image || "/assets/user.png"} />
        </List.Item>
      ))}
    </List>
  );
}
