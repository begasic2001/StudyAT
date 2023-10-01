import { Container } from "semantic-ui-react";
import Navbar from "./Navbar";
import { Outlet } from "react-router-dom";
import { observer } from "mobx-react-lite";
import { useLocation } from "react-router-dom";
import HomePage from "../../services/home/HomePage";
function App() {
  const location = useLocation();

  return (
    <>
      {location.pathname === "/" ? (
        <HomePage />
      ) : (
        <>
          <Navbar />
          <Container style={{ marginTop: "7em" }}>
            <Outlet />
          </Container>
        </>
      )}
    </>
  );
}

export default observer(App);
