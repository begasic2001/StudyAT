import { Grid, Header,Image } from "semantic-ui-react";
import PhotoWidgetDropzone from "./PhotoWidgetDropzone";
import { useState } from "react";

const PhotoUploadWidget = () => {
  const [files,setFiles] = useState<any>([])
  return (
    <Grid>
      <Grid.Column width={4}>
        <Header sub color="teal" content="Step 1 - Add Photo" />
        <PhotoWidgetDropzone setFiles={setFiles}/>
      </Grid.Column>
      <Grid.Column width={1} />
      <Grid.Column width={4}>
        <Header sub color="teal" content="Step 2 - Resize" />
        {files && files.length > 0 && (
          <Image src={files[0].preview}/>
        )}
      </Grid.Column>
      <Grid.Column width={1} />
      <Grid.Column width={4}>
        <Header sub color="teal" content="Step 3 - Preview & Upload" />
      </Grid.Column>
    </Grid>
  );
};

export default PhotoUploadWidget;
