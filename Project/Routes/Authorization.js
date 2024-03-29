import React from "react";
import { Navigate, useLocation, Outlet } from "react-router-dom";
import { useAuth } from "../Provider/AuthProvider";
const Authorization = ({ permissions }) => {
    const { user } = useAuth();
    const location = useLocation();
    if (user.username) {
        const userpermission = user.permissions;
        const isAllowed = permissions.some((allowed) => userpermission.includes(allowed));
        return isAllowed ? <Outlet /> : <Unauthorized />;
    }
    return <Navigate to="/SignIn" state={{ path: location.pathname }} replace />;
};
export default Authorization;