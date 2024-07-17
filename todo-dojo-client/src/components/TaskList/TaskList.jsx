// TaskList.js
import React from 'react';
import Task from '../Task/Task';

function TaskList({ tasks }) {
    return (
        <ul>
            {tasks.map(task => (
                <Task key={task.id} task={task} />
            ))}
        </ul>
    );
}

export default TaskList;
