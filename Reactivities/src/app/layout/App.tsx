import { Container } from "semantic-ui-react";
import Navbar from "./Navbar";
import { Outlet } from "react-router-dom";
import { observer } from "mobx-react-lite";
function App() {
  return (
    <>
      <Navbar />
      <Container style={{ marginTop: "7em" }}>
        <Outlet />
      </Container>
    </>
  );
}

export default observer(App);
