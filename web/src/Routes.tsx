import React from "react";
import { Route, Switch } from "react-router-dom";

import Home from "./core/Home";
import Menu from "./core/Menu";

const Routes: React.FC = () => {
  return (
    <div>
      <Menu />
      <Switch>
        <Route exact path="/" component={Home} />
      </Switch>
    </div>
  );
};

export default Routes;
