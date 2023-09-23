"use client";
import React, { useState } from "react";
export default function Navbar() {
  const [active, setActive] = useState(1);

  function handleClickTab(index: number): void {
    setActive(index);
  }

  return (
    <header
      className="
    sticky top-0 z-50 flex justify-between bg-white p-5 items-center  shadow-md pt-0 pb-0"
    >
      <div>Logo</div>

      <div>
        <ul className="flex justify-center">
          <li
            onClick={() => handleClickTab(1)}
            className={
              active == 1
                ? "my-2 border-x-0 border-b-4 border-t-0 border-transparent px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer border-green-800 transition-all ease-in delay-150"
                : "my-2 border-x-0 border-b-4 border-t-0 border-transparent px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer transition-all ease-in delay-200"
            }
          >
            <a>Home</a>
          </li>
          <li
            onClick={() => handleClickTab(2)}
            className={
              active == 2
                ? "my-2 border-x-0 border-b-4 border-t-0 border-transparent px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer border-green-800 transition-all ease-in delay-150"
                : "my-2 border-x-0 border-b-4 border-t-0 border-transparent px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700  cursor-pointer transition-all ease-in delay-200"
            }
          >
            <a>Courses</a>
          </li>
          <li
            onClick={() => handleClickTab(3)}
            className={
              active == 3
                ? "my-2 border-x-0 border-b-4 border-t-0 border-transparent px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer border-green-800 transition-all ease-in delay-150"
                : "my-2 border-x-0 border-b-4 border-t-0 border-transparent px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer transition-all ease-in delay-200"
            }
          >
            <a>Services</a>
          </li>
          <li
            onClick={() => handleClickTab(4)}
            className={
              active == 4
                ? "my-2 border-x-0 border-b-4 border-t-0 border-transparent px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer border-green-800 transition-all ease-in delay-150"
                : "my-2 border-x-0 border-b-4 border-t-0 border-transparent px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer transition-all ease-in delay-200"
            }
          >
            <a>Blog</a>
          </li>
        </ul>
      </div>

      <div className="flex justify-center">
        <div className="px-2">Signin</div>
        <div>Login</div>
      </div>
    </header>
  );
}
