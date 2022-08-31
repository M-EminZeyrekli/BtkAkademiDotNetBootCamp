import React from "react";
import { Routes, Route } from "react-router-dom";
import ListAuthor from "./pages/admin/author/ListAuthor";
import AddAuthor from "./pages/admin/author/AddAuthor";
import UpdateAuthor from "./pages/admin/author/UpdateAuthor";

import BookDetails from "./components/book/BookDetails";
import BookAdd from "./components/book/BookAdd";

import Home from "./pages/home/Home";

import Counter from "./Counter";
import BookList from "./components/bookList/BookList";
import Search from "./components/search/Search";
import Login from "./components/login/Login";
import Contact from "./components/contact/Contact";

export default function Paths() {
  return (
    <Routes>
      <Route path='/admin/authors/list' element={<ListAuthor />} />
      <Route path='/admin/authors/add' element={<AddAuthor />} />
      <Route path='/admin/authors/update/:id' element={<UpdateAuthor />} />

      <Route path='/books/list' element={<BookList />} />
      <Route path='/books/details/:id' element={<BookDetails />} />
      <Route path='/books/add' element={<BookAdd />} />
      <Route path='/auth/login' element={<Login />} />
      <Route path='/search' element={<Search />} />
      <Route path='/contact' element={<Contact />} />
      <Route path='/' element={<Home />} />
    </Routes>
  );
}
