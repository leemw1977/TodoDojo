import React from 'react';
import { Route, Routes } from 'react-router-dom';
import TaskList from './components/task-list/TaskList';
//import About from './About';
//import Contact from './Contact';


const AppRouter = () => {
    return (
        <Routes>
            <Route path="/" element={<TaskList />} />
        </Routes>
    );
};

export default AppRouter;
