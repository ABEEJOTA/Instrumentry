import * as React from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Modal from '@mui/material/Modal';

const style = {
  position: 'absolute',
  top: '50%',
  left: '50%',
  transform: 'translate(-50%, -50%)',
  width: 'fit-content',
  bgcolor: 'background.paper',
  border: '2px solid #000',
  borderRadius: 5,
  boxShadow: 24,
  p: 4,
  textAlign: 'center'
};

export default function BasicModal(props) {

  const {instrument, index} = props;
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  return (
    <div>
      <Button onClick={handleOpen}>
        <div className="item-container" key={index}>
          <div className="item">
            <div className="container-img">
              <img src={instrument.image}/>
            </div>
            <p>{instrument.model}<br/></p>
            <p>{instrument.brand}</p>
          </div>
        </div>
      </Button>

      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className="item-container" key={index}>
            <div className="item">
              <div className="container-img">
                <img src={instrument.image}/>
              </div>
              <p>{instrument.model}<br/></p>
              <p>{instrument.brand}</p>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
}