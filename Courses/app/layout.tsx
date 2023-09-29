import Navbar from "./components/nav/Navbar";
import "./globals.css";

export default function RootLayout({ children }: { children: any }) {
  return (
    <html lang="en">
      <body className="container-xl">
        <Navbar />
        <main>{children}</main>
      </body>
    </html>
  );
}
