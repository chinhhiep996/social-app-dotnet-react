import React, { useState } from "react";
import {
  Theme,
  CardContent,
  CardMedia,
  withStyles,
  createStyles,
  WithStyles
} from "@material-ui/core";
import Grid from "@material-ui/core/Grid";
import Card from "@material-ui/core/Card";
import Typography from "@material-ui/core/Typography";

const styles = (theme: Theme) =>
  createStyles({
    root: {
      flexGrow: 1,
      margin: 30
    },
    card: {
      maxWidth: 600,
      margin: "auto",
      marginTop: theme.spacing(5)
    },
    title: {
      padding: `
      ${theme.spacing(3)}px
      ${theme.spacing(2.5)}px
      ${theme.spacing(2)}px
    `,
      color: theme.palette.text.secondary
    },
    media: {
      minHeight: 330
    }
  });

interface IProps extends WithStyles<typeof styles> {}

const Home: React.FC<IProps> = props => {
  const [defaultPage, setDefaultPage] = useState(true);

  const { classes } = props;
  return (
    <div className={classes.root}>
      {defaultPage && (
        <Grid container spacing={8}>
          <Grid item xs={4}>
            <Card className={classes.card}>
              <Typography component="h4" className={classes.title}>
                Home Page
              </Typography>
              <CardMedia className={classes.media} title="Unicorn Shells" />
              <CardContent>
                <Typography component="p">
                  Welcome to the Socical Application home page
                </Typography>
              </CardContent>
            </Card>
          </Grid>
        </Grid>
      )}
    </div>
  );
};

export default withStyles(styles)(Home);
