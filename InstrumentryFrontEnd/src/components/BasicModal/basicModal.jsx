import * as React from 'react';
import Box from '@mui/material/Box';
import Modal from '@mui/material/Modal';
import Item from '../Item/item.jsx';

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

  const {instrument} = props;
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  return (
    <div className="felx-element">
      <div onClick={handleOpen} className="item-container">
        <Item image={instrument.image}
              title={instrument.brand}
              subtitle={instrument.model}>
        </Item>
      </div>  
      

      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className="item-container">
            <Item image={instrument.image}
                  title={instrument.brand}
                  subtitle={instrument.model}>
            </Item>
          </div>
        </Box>
      </Modal>
    </div>
  );
}