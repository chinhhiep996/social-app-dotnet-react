import React from "react";
import { withRouter, Link, RouteComponentProps } from "react-router-dom";
import {
  AppBar,
  Toolbar,
  Typography,
  IconButton,
  Button
} from "@material-ui/core";
import { Home } from "@material-ui/icons";
import { History } from "history";

interface IColor {
  color: string;
}

const Menu: React.FC<RouteComponentProps> = props => {
  return (
    <AppBar position="static">
      <Toolbar>
        <Typography variant="h5" color="inherit">
          Social Application
        </Typography>
        <Link to="/">
          <IconButton arial-label="Home" style={isActive(props.history, "/")}>
            <Home />
          </IconButton>
        </Link>

        <Link to="users">
          <Button style={isActive(props.history, "/users")}>Users</Button>
        </Link>
      </Toolbar>
    </AppBar>
  );
};

function isActive(history: History, path: string): IColor {
  if (history.location.pathname === path) return { color: "#ff4081" };
  else return { color: "#ffffff" };
}

export default withRouter(Menu);
