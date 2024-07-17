import React from 'react';
import { Route, Routes } from 'react-router-dom';
import TaskContainer from './components/TasksContainer/TasksContainer';
//import About from './About';
//import Contact from './Contact';


const AppRouter = () => {
    return (
        <Routes>
            <Route path="/" element={<TaskContainer />} />
        </Routes>
    );
};

export default AppRouter;
