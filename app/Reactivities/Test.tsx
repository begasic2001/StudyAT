"use client";
import axios from "axios";
import React, { useState, useEffect } from "react";

export default function Test() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get("https://localhost:9090/api/activities").then((res) => {
      console.log("data fetch::::::::::::", res.data);
      setActivities(res.data);
    });
  }, []);

  return (
    <div>
      <h1>Reactivities</h1>
      <ul>
        {activities.map((activity: any) => {
          <li key={activity.id}>{activity.title}</li>;
        })}
      </ul>
    </div>
  );
}
