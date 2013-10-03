//nRF24L01 Commands
//See datasheet pages 46-47

#define R_REGISTER = 0x00
#define W_REGISTER = 0x20
#define R_RX_PAYLOAD = 0x61
#define W_TX_PAYLOAD = 0xA0
#define FLUSH_TX = 0xE1
#define FLUSH_RX = 0xE2
#define REUSE_TX_PL = 0xE3
#define ACTIVATE = 0x50
#define R_RX_PL_WID = 0x60
#define W_ACK_PAYLOAD = 0xA8
#define W_TX_PAYLOAD_NO_ACK = 0xB0
#define NOP = 0xFF