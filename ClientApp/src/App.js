import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';
import { ToDoList } from './components/ToDoList';

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Routes>
          <Route path='/ToDoList' element={<ToDoList/>} />
        </Routes>
      </Layout>
    );
  }
}
