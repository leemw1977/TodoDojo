import React, { useEffect, useState } from 'react';
import todoService from '../../todo-dojo-service';
import TaskList from '../TaskList/TaskList';

function TasksContainer() {
    const [tasks, setTasks] = useState([]);
    const [loading, setLoading] = useState(true); // Add loading state
    const [error, setError] = useState(null);

    useEffect(() => {
        todoService.getAllOpenTasks()
            .then(tasks => {
                setTasks(tasks);
                setLoading(false);
            })
            .catch(error => {
                setError(error.message);
                setLoading(false);
            });
    }, []);

    return (
        <div>
            {loading ? ( // Check if loading
                <p>Loading...</p>
            ) : error ? (
                <p>Error: {error}</p>
                ) : tasks.length > 0 ? (
                    <div>
                        <h1>Tasks</h1>
                        <TaskList tasks={tasks} />
                    </div>
                //<ul>
                //    {tasks.map(task => (
                //        <li key={task.id}>{task.taskName}</li>
                //    ))}
                //</ul>
            ) : (
                <p>No tasks</p>
            )}
        </div>
    );
}

export default TasksContainer;


//import React, { useEffect, useState } from 'react';
//import todoService from '../../todo-dojo-service';

//function TasksContainer() {
//    const [tasks, setTasks] = useState([]);
//    const [error, setError] = useState(null);

//    useEffect(() => {
//        todoService.getAllOpenTasks()
//            .then(tasks => {
//                setTasks(tasks);
//            })
//            .catch(error => {
//                setError(error.message);
//            });
//    }, []);

//    return (
//        <div>
//            {error ? (
//                <p>Error: {error}</p>
//            ) : tasks.length > 0 ? (
//                <ul>
//                    {tasks.map(task => (
//                        <li key={task.id}>{task.taskName}</li>
//                    ))}
//                </ul>
//            ) : (
//                <p>No tasks</p>
//            )}
//        </div>
//    );
//}

//export default tasks-container;