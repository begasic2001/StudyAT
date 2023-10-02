import { createBrowserRouter, RouteObject } from "react-router-dom";
import App from "../layout/App";
import ActivityDashboard from "../../services/activities/dashboard/ActivityDashboard";
import ActivityForm from "../../services/activities/form/ActivityForm";
import ActivityDetails from "../../services/activities/details/ActivityDetails";
import TestErrors from "../../services/errors/TestError";

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
      {
        path: "errors",
        element: <TestErrors />,
      },
    ],
  },
];
export const router = createBrowserRouter(routes);
