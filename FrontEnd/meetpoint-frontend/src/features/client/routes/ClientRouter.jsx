import { Navigate, Route, Routes } from 'react-router-dom';
import { HomePage, MainPage, EventPage } from '../pages/';

export const ClientRouter = () => {
  return (
    <div className="overflow-x-hidden bg-gray-100 w-screen h-screen   bg-no-repeat bg-cover">
        <Routes>
            <Route path='/home' element={<HomePage/>}/>
            <Route path='/main' element={<MainPage/>}/>
            <Route path='/main/event/:id' element={<EventPage/>}/>
            <Route path='/*' element={<Navigate to={"/home"}/>}/>
        </Routes>
    </div>
  )
}
