// Task.js
import React from 'react';

function Task({ task }) {
  return (
      <li>{task.taskName}</li>
  );
}

export default Task;