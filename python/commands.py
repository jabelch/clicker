#nRF24L01 Commands
#See datasheet pages 46-47

R_REGISTER = 0x00
W_REGISTER = 0x20
R_RX_PAYLOAD = 0x61
W_TX_PAYLOAD = 0xA0
FLUSH_TX = 0xE1
FLUSH_RX = 0xE2
REUSE_TX_PL = 0xE3
ACTIVATE = 0x50
R_RX_PL_WID = 0x60
W_ACK_PAYLOAD = 0xA8
W_TX_PAYLOAD_NO_ACK = 0xB0
NOP = 0xFF