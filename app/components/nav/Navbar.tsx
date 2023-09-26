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
    sticky top-0 z-50 flex justify-between bg-white p-5 items-center pt-0 pb-0"
    >
      <div>
        <img
          src="data:image/png;base64,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"
          alt="Logo"
          width="100px"
          height="100px"
        />
      </div>

      <div>
        <ul className="flex justify-center">
          <li
            onClick={() => handleClickTab(1)}
            className={
              active == 1
                ? "my-2 border-x-0 border-b-4 border-t-0  px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer border-green-800 transition-all ease-in delay-150"
                : "my-2 border-x-0 border-b-4 border-t-0  px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight  cursor-pointer border-transparent"
            }
          >
            <a>Home</a>
          </li>
          <li
            onClick={() => handleClickTab(2)}
            className={
              active == 2
                ? "my-2 border-x-0 border-b-4 border-t-0  px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer border-green-800 transition-all ease-in delay-150"
                : "my-2 border-x-0 border-b-4 border-t-0  px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight   cursor-pointer border-transparent"
            }
          >
            <a>Courses</a>
          </li>
          <li
            onClick={() => handleClickTab(3)}
            className={
              active == 3
                ? "my-2 border-x-0 border-b-4 border-t-0  px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer border-green-800 transition-all ease-in delay-150"
                : "my-2 border-x-0 border-b-4 border-t-0  px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight  cursor-pointer border-transparent"
            }
          >
            <a>Services</a>
          </li>
          <li
            onClick={() => handleClickTab(4)}
            className={
              active == 4
                ? "my-2 border-x-0 border-b-4 border-t-0  px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight text-green-700 cursor-pointer border-green-800 transition-all ease-in delay-150"
                : "my-2 border-x-0 border-b-4 border-t-0  px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight  cursor-pointer border-transparent"
            }
          >
            <a>Blog</a>
          </li>
        </ul>
      </div>

      <div className="flex justify-center">
        <div className="my-2 mr-3 px-7 pb-3.5 pt-4 text-sm font-medium uppercase leading-tight border-2 text-center border-black rounded-md cursor-pointer">
          Login
        </div>
        <div className="my-2 px-7 pb-3.5 pt-4 text-sm uppercase leading-tight border-2 font-light text-white bg-orange-600 rounded-md cursor-pointer">
          Sign Up
        </div>
      </div>
    </header>
  );
}
