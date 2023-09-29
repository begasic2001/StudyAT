import { Menu, Container, Button } from "semantic-ui-react";
import "./style.css";
interface Props {
  openForm: () => void;
}

export default function Navbar({ openForm }: Props) {
  return (
    <Menu inverted fixed="top">
      <Container>
        <Menu.Item header>
          <img src="/assets/logo.png" style={{ marginRight: "7em" }} />
          Reactivity
        </Menu.Item>
        <Menu.Item name="Activities" />
        <Menu.Item>
          <Button onClick={openForm} positive content="Create Activity" />
        </Menu.Item>
      </Container>
    </Menu>
  );
}
