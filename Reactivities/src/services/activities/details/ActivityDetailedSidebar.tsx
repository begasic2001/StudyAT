import { Segment, List, Label, Item, Image } from "semantic-ui-react";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";
import { Profile } from "../../../app/models/profile";
import { Activity } from "../../../app/models/activity";
interface Props {
  activity: Activity;
}
export default observer(function ActivityDetailedSidebar({
  activity: { attendees, host },
}: Props) {
  if (!attendees) return null;
  return (
    <>
      <Segment
        textAlign="center"
        style={{ border: "none" }}
        attached="top"
        secondary
        inverted
        color="teal"
      >
        {attendees.length} {attendees.length === 1 ? "Person" : "People"}
      </Segment>
      <Segment attached>
        <List relaxed divided>
          {attendees.map((a) => (
            <Item style={{ position: "relative" }} key={a.userName}>
              {a.userName === host?.userName && (
                <Label
                  style={{ position: "absolute" }}
                  color="orange"
                  ribbon="right"
                >
                  Host
                </Label>
              )}
              <Image size="tiny" src={a.image || "/assets/user.png"} />
              <Item.Content verticalAlign="middle">
                <Item.Header as="h3">
                  <Link to={`/profiles/${a.userName}`}>{a.displayName}</Link>
                </Item.Header>
                <Item.Extra style={{ color: "orange" }}>Following</Item.Extra>
              </Item.Content>
            </Item>
          ))}
        </List>
      </Segment>
    </>
  );
});
