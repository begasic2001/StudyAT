import { createBrowserRouter, Navigate, RouteObject } from "react-router-dom";
import App from "../layout/App";
import ActivityDashboard from "../../services/activities/dashboard/ActivityDashboard";
import ActivityForm from "../../services/activities/form/ActivityForm";
import ActivityDetails from "../../services/activities/details/ActivityDetails";
import TestErrors from "../../services/errors/TestError";
import NotFound from "../../services/errors/NotFound";
import ServerError from "../../services/errors/ServerError";
import LoginForm from "../../services/users/form/LoginForm";
import ProfilePage from "../../services/profiles/ProfilePage";

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
        path: "profiles/:username",
        element: <ProfilePage />,
      },
      {
        path: "login",
        element: <LoginForm />,
      },
      {
        path: "errors",
        element: <TestErrors />,
      },
      {
        path: "not-found",
        element: <NotFound />,
      },
      {
        path: "server-error",
        element: <ServerError />,
      },
      {
        path: "*",
        element: <Navigate replace to={"/not-found"} />,
      },
    ],
  },
];
export const router = createBrowserRouter(routes);
