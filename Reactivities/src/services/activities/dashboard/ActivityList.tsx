import { Header, Item, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";
import { observer } from "mobx-react-lite";
import ActivityListItem from "./ActivityListItem";
import { Fragment } from "react";

export default observer(function ActivityList() {
  const { activityStore } = useStore();
  const { activityByDate, groupedActivities } = activityStore;
  const [a, b] = groupedActivities;
  console.log(a[0]);
  console.log(b);
  return (
    <>
      {groupedActivities.map(([date, activities]) => (
        <Fragment key={date}>
          <Header sub color="teal">
            {date}
          </Header>
          <Segment>
            <Item.Group divided>
              {activities.map((activity) => (
                <ActivityListItem key={activity.id} activity={activity} />
              ))}
            </Item.Group>
          </Segment>
        </Fragment>
      ))}
    </>
  );
});
