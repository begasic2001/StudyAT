import { Button, Icon, Item, Label, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import { Link } from "react-router-dom";
import { useStore } from "../../../app/stores/store";
import { format } from "date-fns";
import { SyntheticEvent, useState } from "react";
interface Props {
  activity: Activity;
}

export default function ActivityListItem({ activity }: Props) {
  const { activityStore } = useStore();
  const { loading, deleteActivity } = activityStore;
  const [target, setTarget] = useState("");

  const handleActivityDelete = (
    e: SyntheticEvent<HTMLButtonElement>,
    id: string
  ) => {
    setTarget(e.currentTarget.name);
    deleteActivity(id);
  };
  return (
    <Segment.Group>
      <Segment>
        <Item.Group>
          <Item.Image size="tiny" circular src="/assets/user.png" />
          <Item.Content>
            <Item.Header as={Link} to={`/activity/${activity.id}`}>
              {activity.title}
            </Item.Header>
            <Item.Description>Hosted By Bob</Item.Description>
          </Item.Content>
        </Item.Group>
      </Segment>
      <Segment>
        <span>
          <Icon name="clock" />
          {format(activity.date!, "dd MMMM yyyy h:mm aa")}
          <Icon name="marker" /> {activity.venue}
        </span>
      </Segment>
      <Segment secondary>Attendees go here</Segment>
      <Segment clearing>
        <span>{activity.description}</span>
        <Button
          as={Link}
          to={`/activity/${activity.id}`}
          color="teal"
          floated="right"
          content="View"
        />
      </Segment>
    </Segment.Group>
  );
}
