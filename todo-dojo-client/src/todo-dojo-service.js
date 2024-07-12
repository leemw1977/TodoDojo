// todoService.js
import axios from 'axios';

const API_URL = 'https://localhost:7243/api';

// Generic function to handle responses and parse as JSON
const handleResponse = (response) => {
    try {
        return response.data;
    } catch (error) {
        throw new Error('Failed to parse response as JSON');
    }
};

// Generic function to handle errors
const handleError = (error) => {
    if (error.response) {
        console.error('Error response:', error.response);
        throw new Error(error.response.data.message || 'Server Error');
    } else if (error.request) {
        console.error('Error request:', error.request);
        throw new Error('Network Error');
    } else {
        console.error('Error message:', error.message);
        throw new Error(error.message);
    }
};

// Specific function to get all open tasks
const getAllOpenTasks = () => {
    return axios.get(`${API_URL}/tasks`)
        .then(handleResponse)
        .catch(handleError);
};

// Other functions related to tasks
const getTaskById = (id) => {
    return axios.get(`${API_URL}/tasks/${id}`)
        .then(handleResponse)
        .catch(handleError);
};

//const createTask = (taskData) => {
//    return axios.post(`${API_URL}/tasks`, taskData)
//        .then(handleResponse)
//        .catch(handleError);
//};

//const updateTask = (id, taskData) => {
//    return axios.put(`${API_URL}/tasks/${id}`, taskData)
//        .then(handleResponse)
//        .catch(handleError);
//};

//const deleteTask = (id) => {
//    return axios.delete(`${API_URL}/tasks/${id}`)
//        .then(handleResponse)
//        .catch(handleError);
//};

export default {
    getAllOpenTasks,
    getTaskById,
    //createTask,
    //updateTask,
    //deleteTask,
};
