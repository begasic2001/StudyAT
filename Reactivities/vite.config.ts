import { defineConfig } from "vite";
import react from "@vitejs/plugin-react-swc";
import mkcert from "vite-plugin-mkcert";
// https://vitejs.dev/config/
export default defineConfig({
  build: {
    outDir: "../../StudyAT_BE/src/Reactivities/Reactivities.API/wwwroot",
  },
  server: {
    port: 3000,
    https: true,
  },
  plugins: [react(), mkcert()],
});
