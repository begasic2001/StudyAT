import { Button, Container, Header } from "semantic-ui-react";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";
import { useStore } from "../../app/stores/store";
import LoginForm from "../users/form/LoginForm";
import RegisterForm from "../users/form/RegisterForm";
export default observer(function HomePage() {
  const { userStore, modalStore } = useStore();
  return (
    <Container style={{ marginTop: "7em" }}>
      <div>HomePage</div>
      {userStore.isLoggedIn ? (
        <>
          <Header as="h2" inverted content="welcome to activity forum" />
          <Button as={Link} to={"/activity"} content="Go To Activity"></Button>
        </>
      ) : (
        <>
          <Button
            content="Login"
            onClick={() => modalStore.openModal(<LoginForm />)}
          ></Button>
          <Button
            content="Register"
            onClick={() => modalStore.openModal(<RegisterForm />)}
          ></Button>
        </>
      )}
    </Container>
  );
});
