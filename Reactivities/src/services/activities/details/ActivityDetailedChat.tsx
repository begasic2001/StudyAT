import { observer } from "mobx-react-lite";
import { Segment, Header, Comment, Button } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";
import { useEffect } from "react";
import { Link } from "react-router-dom";
import { Formik, Form } from "formik";
import MyTextArea from "../../../app/common/form/MyTextArea";

interface Props {
  activityId: string;
}

export default observer(function ActivityDetailedChat({ activityId }: Props) {
  const { commentStore } = useStore();
  const { comments } = commentStore;
  useEffect(() => {
    if (activityId) {
      commentStore.createHubConnection(activityId);
    }

    return () => {
      commentStore.clearComments();
    };
  }, [commentStore, activityId]);
  return (
    <>
      <Segment
        textAlign="center"
        attached="top"
        inverted
        color="teal"
        style={{ border: "none" }}
      >
        <Header>Chat about this event</Header>
      </Segment>
      <Segment attached clearing>
        <Comment.Group>
          {comments.map((comment) => (
            <Comment key={comment.id}>
              <Comment.Avatar src={comment.image || "/assets/user.png"} />
              <Comment.Content>
                <Comment.Author as={Link} to={`/profiles/${comment.username}`}>
                  {comment.displayName}
                </Comment.Author>
                <Comment.Metadata>
                  <div>{comment.createdAt.toString()}</div>
                </Comment.Metadata>
                <Comment.Text>{comment.body}</Comment.Text>
                <Comment.Actions>
                  <Comment.Action>Reply</Comment.Action>
                </Comment.Actions>
              </Comment.Content>
            </Comment>
          ))}

          <Formik
            onSubmit={(values, { resetForm }) =>
              commentStore.addComment(values).then(() => resetForm())
            }
            initialValues={{ body: "" }}
          >
            {({ isSubmitting, isValid }) => (
              <Form className="ui form">
                <MyTextArea placeholder="Add Comment" row={2} name="body" />
                <Button
                  loading={isSubmitting}
                  disabled={isSubmitting || !isValid}
                  content="Add Reply"
                  labelPosition="left"
                  icon="edit"
                  primary
                  type="submit"
                  floated="right"
                />
              </Form>
            )}
          </Formik>
        </Comment.Group>
      </Segment>
    </>
  );
});
