import { Button, Segment } from "semantic-ui-react";
import { useParams, useNavigate, Link } from "react-router-dom";
import { useEffect, useState } from "react";
import { useStore } from "../../../app/stores/store";
import { observer } from "mobx-react-lite";
import { Activity } from "../../../app/models/activity";
import Loading from "../../../app/layout/Loading";
import { Formik, Form } from "formik";
import * as Yup from "yup";
import MyTextInput from "../../../app/common/form/MyTextInput";
import MyTextArea from "../../../app/common/form/MyTextArea";
import { categoryOptions } from "../../../app/common/options/categoryOptions";
import MySelectedInput from "../../../app/common/form/MySelectInput";
import MyDateInput from "../../../app/common/form/MyDateInput";
export default observer(function ActivityForm() {
  const { activityStore } = useStore();
  const { loading, loadActivity, loadingInitial } = activityStore;
  const { id } = useParams<{ id: string }>();
  const [activity, setActivity] = useState<Activity>({
    id: "",
    title: "",
    category: "",
    description: "",
    date: null,
    city: "",
    venue: "",
  });
  const navigate = useNavigate();
  const validationSchema = Yup.object({
    title: Yup.string().required("The activity title is required"),
    description: Yup.string().required("The activity title is required"),
    category: Yup.string().required(),
    date: Yup.string().required(),
    venue: Yup.string().required(),
    city: Yup.string().required(),
  });
  useEffect(() => {
    if (id) loadActivity(id).then((activity) => setActivity(activity!));
  }, [id, loadActivity]);
  // const handleSubmit = () => {
  //   if (activity.id) {
  //     updateActivity(activity).then(() => navigate(`/activity/${activity.id}`));
  //   } else {
  //     activity.id = uuid();
  //     createActivity(activity).then(() => navigate(`/activity/${activity.id}`));
  //   }
  // };
  // const handleInputChange = (
  //   event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  // ) => {
  //   const { name, value } = event.target;
  //   setActivity({ ...activity, [name]: value });
  // };

  if (loadingInitial) return <Loading content="Loading App ......" />;

  return (
    <Segment clearing>
      <Formik
        validationSchema={validationSchema}
        enableReinitialize
        initialValues={activity}
        onSubmit={(values) => console.log(values)}
      >
        {({ handleSubmit }) => (
          <Form className="ui form" onSubmit={handleSubmit}>
            <MyTextInput name="title" placeholder="title" />
            <MyTextArea row={3} placeholder="Description" name="description" />
            <MySelectedInput
              options={categoryOptions}
              placeholder="Category"
              name="category"
            />
            <MyDateInput
              placeholderText="Date"
              name="date"
              showTimeSelect
              timeCaption="time"
              dateFormat="MMMM dd, yyyy h:mm aa"
            />
            <MyTextInput placeholder="City" name="city" />
            <MyTextInput placeholder="Venue" name="venue" />
            <Button
              loading={loading}
              floated="right"
              positive
              type="submit"
              content="Submit"
            />
            <Button
              as={Link}
              to={`/activity`}
              floated="right"
              positive
              type="button"
              basic
              color="grey"
              content="Cancel"
            />
          </Form>
        )}
      </Formik>
    </Segment>
  );
});
