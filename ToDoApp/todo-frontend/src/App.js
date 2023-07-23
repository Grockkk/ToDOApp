
import { Routes, Route } from "react-router-dom";
import ToDoCrud from "./components/ToDoCrud";
import Show from "./components/Show";


function App() {
  return (
       <Routes>
          <Route path="/ToDoCrud" element={<ToDoCrud />} />
            <Route path="/Show/:id" element={<Show />} />
          
       </Routes>
 );
}

export default App;
