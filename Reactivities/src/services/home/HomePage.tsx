import { Button, Container } from "semantic-ui-react";
import { Link } from "react-router-dom";
export default function HomePage() {
  return (
    <Container style={{ marginTop: "7em" }}>
      <div>HomePage</div>
      <Button as={Link} to={"/login"} content="Login"></Button>
    </Container>
  );
}
