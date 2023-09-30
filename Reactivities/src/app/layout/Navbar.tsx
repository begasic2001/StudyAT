import { Menu, Container, Button } from "semantic-ui-react";
import "./style.css";
import { NavLink } from "react-router-dom";
export default function Navbar() {
  return (
    <Menu inverted fixed="top">
      <Container>
        <Menu.Item as={NavLink} to="/" header>
          <img src="/assets/logo.png" style={{ marginRight: 10 }} />
          Reactivity
        </Menu.Item>
        <Menu.Item as={NavLink} to="/activity" name="Activities" />
        <Menu.Item as={NavLink} to="/createActivity">
          <Button positive content="Create Activity" />
        </Menu.Item>
      </Container>
    </Menu>
  );
}
