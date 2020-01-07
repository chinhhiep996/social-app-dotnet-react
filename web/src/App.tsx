import React from "react";
import { BrowserRouter } from "react-router-dom";
import { MuiThemeProvider, createMuiTheme } from "@material-ui/core";

import "./App.css";
import Routes from "./Routes";

const theme = createMuiTheme({
  palette: {
    primary: {
      light: "#757de8",
      main: "#3f51b5",
      dark: "#002984",
      contrastText: "#fff"
    },
    secondary: {
      light: "#ff79b0",
      main: "#ff4081",
      dark: "#c60055",
      contrastText: "#000"
    },
    type: "light"
  }
});

const App: React.FC = () => {
  return (
    <BrowserRouter>
      <MuiThemeProvider theme={theme}>
        <Routes />
      </MuiThemeProvider>
    </BrowserRouter>
  );
};

export default App;
