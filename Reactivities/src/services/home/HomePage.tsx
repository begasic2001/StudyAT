import { Container } from "semantic-ui-react";
import { Link } from "react-router-dom";
export default function HomePage() {
  return (
    <Container style={{ marginTop: "7em" }}>
      <div>HomePage</div>
      <div>
        Go to <Link to="/activity">activity</Link>
      </div>
    </Container>
  );
}
