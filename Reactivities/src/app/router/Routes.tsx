import { createBrowserRouter, RouteObject } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../../services/home/HomePage";
import ActivityDashboard from "../../services/activities/dashboard/ActivityDashboard";
import ActivityForm from "../../services/activities/form/ActivityForm";
import ActivityDetails from "../../services/activities/details/ActivityDetails";

export const routes: RouteObject[] = [
  {
    path: "/",
    element: <App />,
    children: [
      {
        path: "activity",
        element: <ActivityDashboard />,
      },
      {
        path: "activity/:id",
        element: <ActivityDetails />,
      },

      {
        path: "createActivity",
        element: <ActivityForm key="create" />,
      },
      {
        path: "manage/:id",
        element: <ActivityForm key="manage" />,
      },
      // <ActivityDashboard />
    ],
  },
];
export const router = createBrowserRouter(routes);
