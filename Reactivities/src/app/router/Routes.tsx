import { createBrowserRouter, RouteObject } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../../services/home/HomePage";
import ActivityDashboard from "../../services/activities/dashboard/ActivityDashboard";
import ActivityForm from "../../services/activities/form/ActivityForm";

export const routes: RouteObject[] = [
  {
    path: "/",
    element: <App />,
    children: [
      {
        path: "",
        element: <HomePage />,
      },
      {
        path: "activity",
        element: <ActivityDashboard />,
      },
      {
        path: "createActivity",
        element: <ActivityForm />,
      },
      // <ActivityDashboard />
    ],
  },
];
export const router = createBrowserRouter(routes);
