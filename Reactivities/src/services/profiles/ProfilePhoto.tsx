import { Header, Tab,Card,Image } from "semantic-ui-react"
import { Profile } from "../../app/models/profile"

interface Props{
  profile:Profile
}
const ProfilePhoto = ({profile}:Props) => {
  return (
   <Tab.Pane>
    <Header icon='image' content='Photo'/>
    <Card.Group itemsPerRow={5}>
      {profile.photos?.map(photo =>(
          <Card key={photo.id}>
          <Image src={photo.url} />
        </Card>
      ))}
    
    </Card.Group>
   </Tab.Pane>
  )
}

export default ProfilePhoto