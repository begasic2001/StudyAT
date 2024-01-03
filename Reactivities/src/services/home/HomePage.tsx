import { Button, Container, Divider, Header } from "semantic-ui-react";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";
import { useStore } from "../../app/stores/store";
import LoginForm from "../users/form/LoginForm";
import RegisterForm from "../users/form/RegisterForm";
import FacebookLogin, {
  FailResponse,
  SuccessResponse,
} from "@greatsumini/react-facebook-login";
export default observer(function HomePage() {
  const { userStore, modalStore } = useStore();
  return (
    <Container style={{ marginTop: "7em" }}>
      <div>Home Page</div>
      {userStore.isLoggedIn ? (
        <>
          <Header
            as="h2"
            inverted
            content={`welcome back ${userStore.user?.userName}`}
          />
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
          <Divider horizontal inverted>
            Or
          </Divider>
          <FacebookLogin
            appId="1415614765699338"
            onSuccess={(response: SuccessResponse) => {
              userStore.facebookLogin(response.accessToken);
            }}
            onFail={(response: FailResponse) => {
              console.log(response);
            }}
            className={`ui button facebook huge inverted ${
              userStore.fbLoading && "loading"
            }`}
          />
        </>
      )}
    </Container>
  );
});
