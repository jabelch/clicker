prog_char FreeMemory[] PROGMEM = "freeMemory()=";
prog_char TrigRandMass[] PROGMEM = "Triggered random mass send.\n";
prog_char ChangeAnswer[] PROGMEM = "Changed default answer to ";
prog_char TrigMass[] PROGMEM = "Triggered unanimous mass send.\n";
prog_char TrigSingle[] PROGMEM = "Triggered single send.\n";
prog_char ClearedStats[] PROGMEM = "Cleared Statistics.\n\n";
prog_char FinRandMass[] PROGMEM = "Finished random mass send.\n\n";
prog_char FinMass[] PROGMEM = "Finished unanimous mass send.\n\n";
prog_char FinSingle[] PROGMEM = "Finsihed sending single answer\n\n";
prog_char ChannelSet[] PROGMEM = "Channel set to ";
prog_char DefaultMode[] PROGMEM = "Entering Default Mode\n";
prog_char AutoAnswer[] PROGMEM = "Entering Auto Answer Mode\n";
prog_char ChangedByAA[] PROGMEM = "Auto-Answer sent new answer: ";
prog_char NewLine[] PROGMEM = "\n";

prog_char Registers[] PROGMEM = "<registers>\n";
prog_char Colen[] PROGMEM = ": ";
prog_char RegistersN[] PROGMEM = "</registers>\n";

prog_char Macs[] PROGMEM = "<macs>\n";
prog_char MacsN[] PROGMEM = "</macs>\n";
prog_char MacsFormat[] PROGMEM = "%02X ";
prog_char Stats[] PROGMEM = "<stats>\n";
prog_char StatFormat[] PROGMEM = "%c: %3hu - ";
prog_char Percent[] PROGMEM = "%\n";
prog_char Total[] PROGMEM = "Total: ";
prog_char PopularAnswer[] PROGMEM = "Popular answer: ";
prog_char StatsN[] PROGMEM = "\n</stats>\n";
prog_char EnterReceiveMode[] PROGMEM = "Entering receive as clicker master mode...\n";

prog_char ConstantCarrierMode[] PROGMEM = "Entering constant carrier mode...\n";
prog_char TransmitCarrier[] PROGMEM = "Transmitting Carrier.\n\n";
prog_char EnterTransmitMode[] PROGMEM = "Entering send as clicker mode...\n";

prog_char Help[][50] PROGMEM = {  "------------------------------------------------\n",
                                  "  nRF24L01 Fake Clicker v1                      \n",
                                  "        -By Taylor Killian                      \n",
                                  "            http://www.taylorkillian.com        \n",
                                  "                                                \n",
                                  "  h - This help screen                          \n",
                                  "  r - Read nRF24L01 registers                   \n",
                                  "  g - Send out random answers for all clickers  \n",
                                  "  m - Send out the same answer for all clickers \n",
                                  "  s - Send out an answer for one clicker        \n",
                                  "  c? - Change answer to send to ?               \n",
                                  "  t - Show statistics from other clickers       \n",
                                  "  n - Next question, restart statistics         \n",
                                  "  ; - Seperates commands                        \n",
                                  "  fNN. - Channel is set to NN                   \n",
                                  "  a - Auto-Answer Questions                     \n",
                                  "  d - Do not Auto-Answer Questions              \n",
                                  "  p - Display the recorded MACs                 \n",
                                  "  j - Send out a constant carrier               \n",
                                  "  b####. - Specify mac address and answer       \n",
                                  "                                                \n",
                                  "  Ex: c4m;c1s                                   \n",
                                  "        -All clickers send out '4' as answer    \n",
                                  "        -Then single cicker sends out '1'       \n",
                                  "------------------------------------------------\n" };
