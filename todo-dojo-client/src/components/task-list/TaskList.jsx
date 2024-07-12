import React, { useEffect, useState } from 'react';
import todoService from '../../todo-dojo-service';

const TaskList = () => {
    const [tasks, setTasks] = useState([]);
    const [error, setError] = useState(null);

    useEffect(() => {
        todoService.getAllOpenTasks()
            .then(tasks => {
                setTasks(tasks);
            })
            .catch(error => {
                setError(error.message);
            });
    }, []);

    return (
        <div>
            {error ? (
                <p>Error: {error}</p>
            ) : tasks.length > 0 ? (
                <ul>
                    {tasks.map(task => (
                        <li key={task.id}>{task.taskName}</li>
                    ))}
                </ul>
            ) : (
                <p>No open tasks</p>
            )}
        </div>
    );
};

export default TaskList;
