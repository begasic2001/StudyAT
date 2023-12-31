import { Grid, GridColumn, Loader } from "semantic-ui-react";
import ActivityList from "./ActivityList";
import { useStore } from "../../../app/stores/store";
import { observer } from "mobx-react-lite";
import { useEffect, useState } from "react";
import ActivityFilter from "./ActivityFilter";
import { PagingParams } from "../../../app/models/pagination";
import InfiniteScroll from "react-infinite-scroller";
import ActivityListItemPlaceholder from "./ActivityListItemPlaceholder";
export default observer(function ActivityDashboard() {
  const { activityStore } = useStore();
  const { loadActivities, activityRegistry, setPagingParams, pagination } =
    activityStore;

  const [loadingNext, setLoadingNext] = useState(false);

  const handleGetNext = () => {
    setLoadingNext(true);
    setPagingParams(new PagingParams(pagination!.currentPage + 1));
    loadActivities().then(() => setLoadingNext(false));
  };

  useEffect(() => {
    if (activityRegistry.size <= 1) loadActivities();
  }, [loadActivities]);

  // if (activityStore.loadingInitial && !loadingNext)
  //   return <Loading content="Loading Activity..." />;
  return (
    <Grid>
      <Grid.Column width="10">
        {activityStore.loadingInitial &&
        activityStore.activityRegistry.size === 0 &&
        !loadingNext ? (
          <>
            <ActivityListItemPlaceholder />
            <ActivityListItemPlaceholder />
          </>
        ) : (
          <InfiniteScroll
            pageStart={0}
            loadMore={handleGetNext}
            hasMore={
              !loadingNext &&
              !!pagination &&
              pagination.currentPage < pagination.totalPages
            }
            initialLoad={false}
          >
            <ActivityList />
          </InfiniteScroll>
        )}

        {/* <Button
          floated="right"
          content="More"
          positive
          onClick={handleGetNext}
          loading={loadingNext}
          disabled={pagination?.totalPages === pagination?.currentPage}
        /> */}
      </Grid.Column>
      <Grid.Column width="6">
        <ActivityFilter />
      </Grid.Column>
      <GridColumn width={10}>
        <Loader active={loadingNext} />
      </GridColumn>
    </Grid>
  );
});
