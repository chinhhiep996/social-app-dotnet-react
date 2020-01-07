import React, { useState } from "react";
import {
  Card,
  CardActions,
  CardContent,
  Button,
  TextField,
  Typography,
  Icon,
  withStyles,
  Theme,
  createStyles,
  WithStyles
} from "@material-ui/core";

const styles = (theme: Theme) =>
  createStyles({
    card: {
      maxWidth: 600,
      margin: "auto",
      textAlign: "center",
      marginTop: theme.spacing(5),
      paddingBottom: theme.spacing(2)
    },
    error: {
      verticalAlign: "middle"
    },
    title: {
      marginTop: theme.spacing(2),
      color: theme.palette.primary.main
    },
    textField: {
      marginLeft: theme.spacing,
      marginRight: theme.spacing,
      width: 300
    },
    submit: {
      margin: "auto",
      marginBottom: theme.spacing(2)
    }
  });

interface IProps extends WithStyles<typeof styles> {}

const Signup: React.FC<IProps> = props => {
  const { classes } = props;
  const [name, setName] = useState("");
  const [password, setPassword] = useState("");
  const [email, setEmail] = useState("");
  const [open, setOpen] = useState(false);
  const [error, setError] = useState("");

  const handleChangeName = (e: React.ChangeEvent<HTMLInputElement>) => {
    setName(e.target.value);
  }

  return <div>
    <Card className={classes.card}>
      <CardContent>
        <Typography variant='h3' component='h3' className={classes.title}>
          Sign Up
        </Typography>
      </CardContent>
    </Card>
  </div>;
};

export default Signup;
