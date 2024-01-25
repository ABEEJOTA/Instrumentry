import * as React from 'react';
import { styled } from '@mui/material/styles';
import Box from '@mui/material/Box';
import Paper from '@mui/material/Paper';
import Grid from '@mui/material/Grid';


const Item = styled(Paper)(({ theme }) => ({
  backgroundColor: theme.palette.mode === 'dark' ? '#1A2027' : '#fff',
  ...theme.typography.body2,
  padding: theme.spacing(1),
  paddingTop: '30px',
  textAlign: 'center',
  color: theme.palette.text.secondary,
  height: '300px',
}));

export default function BasicGrid(props) {

  const {instrument} = props;
  console.log(instrument);

  return (
    <Box sx={{ flexGrow: 1, width:'1200px'}}>
      <Grid container spacing={2}>
      {instrument.map((instrument, index) => (
            <Grid key={index} item xs={3}>
            <Item>
              <img src={instrument.image}/>
              <p>{instrument.model}<br/></p>
              <p>{instrument.brand}</p>
            </Item>
            </Grid>
      ))}
      </Grid>
    </Box>
  );
}