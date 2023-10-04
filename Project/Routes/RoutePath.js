import SignInPage from "../Components/SignIn";

<Route element={<Authorization permissions={[PERMISSIONS.CAN_VIEW_ABOUT]} />}>
    <Route path="SignIn" element={<SignInPage />} />
</Route>;