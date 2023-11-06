import "./globals.css";

export default function RootLayout({ children }: { children: any }) {
  return (
    <html lang="en">
      <body className="">
        <main>{children}</main>
      </body>
    </html>
  );
}
