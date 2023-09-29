import { Button, Form, Segment } from "semantic-ui-react";
import { Activity } from "../../../app/models/activity";
import { ChangeEvent, useState } from "react";

interface Props {
  activity: Activity | undefined;
  closeForm: () => void;
  createOrEdit: (activity: Activity) => void;
}

export default function ActivityForm({
  activity: selectedActivity,
  closeForm,
  createOrEdit,
}: Props) {
  const initState = selectedActivity ?? {
    id: "",
    title: "",
    category: "",
    description: "",
    date: "",
    city: "",
    venue: "",
  };
  const [activity, setActivity] = useState(initState);

  const handleSubmit = () => {
    createOrEdit(activity);
  };
  const handleInputChange = (
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { name, value } = event.target;
    setActivity({ ...activity, [name]: value });
  };

  return (
    <Segment clearing>
      <Form onSubmit={handleSubmit}>
        <Form.Input
          placeholder="Title"
          name="title"
          value={activity.title}
          onChange={handleInputChange}
        />
        <Form.TextArea
          placeholder="Description"
          name="description"
          value={activity.description}
          onChange={handleInputChange}
        />
        <Form.Input
          placeholder="Category"
          name="category"
          value={activity.category}
          onChange={handleInputChange}
        />
        <Form.Input
          placeholder="Date"
          name="date"
          value={activity.date}
          onChange={handleInputChange}
        />
        <Form.Input
          placeholder="City"
          name="city"
          value={activity.city}
          onChange={handleInputChange}
        />
        <Form.Input
          placeholder="Venue"
          name="venue"
          value={activity.venue}
          onChange={handleInputChange}
        />
        <Button floated="right" positive type="submit" content="Submit" />
        <Button
          onClick={closeForm}
          floated="right"
          positive
          type="button"
          basic
          color="grey"
          content="Cancel"
        />
      </Form>
    </Segment>
  );
}
