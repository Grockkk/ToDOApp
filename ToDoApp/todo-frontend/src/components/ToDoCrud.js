import axios from "axios";
import { useEffect, useState } from "react";
import { useNavigate  } from 'react-router-dom';

function ToDoCrud() {
    //const [id, setId] = useState("");
    //const [name, setName] = useState("");
    //const [description, setDescription] = useState("");
    //const [importance, setImportance] = useState("");
    //const [date, setDate] = useState("");
    //const [status, setStatus] = useState("");
    const navigate = useNavigate();
    const [tasks, setTasks] = useState([]);

    useEffect(() => {
        (async () => {
            await Load();
        })();
    }, []);

    async function Load() {
        try {
            const response = await axios.get("https://localhost:7210/api/Task");
            console.log(response)
            setTasks(response.data);
            console.log(response.data);
        } catch (error) {
            console.log(error);
        }
    }

    const handleClick=()=>{
        //navigating to Home 
        navigate('/Show')
      }
    

    return (
        <div>
            <h2>Todo Details</h2>
                <div className="container mt-4">
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Date</th>
                        <th>Importance</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {tasks.map((task) => (
                        <tr key={task.id}>
                            <td>{task.name}</td>
                            <td>{task.description}</td>
                            <td>{task.date}</td>
                            <td>{task.importance}</td>
                            <td>
                                <button onClick={handleClick}>Details</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
            </div>
        </div>
    );
}

export default ToDoCrud;
