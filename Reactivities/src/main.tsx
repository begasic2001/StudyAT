import React from "react";
import ReactDOM from "react-dom/client";
import "react-calendar/dist/Calendar.css";
import "semantic-ui-css/semantic.min.css";
import "react-datepicker/dist/react-datepicker.css";
import "react-toastify/dist/ReactToastify.min.css";
import { StoreContext, store } from "./app/stores/store.ts";
import { router } from "./app/router/Routes.tsx";
import { RouterProvider } from "react-router-dom";
ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <StoreContext.Provider value={store}>
      <RouterProvider router={router} />
    </StoreContext.Provider>
  </React.StrictMode>
);
