/* Program Diagram 

                        -------------------
                        |     Program     |
                        -------------------
                        |    -Journal     |
                        -------------------
                                
                            
                +------+--------+           +-------+-----+
                |  PromptList   |           |     Entry   |
                +-----------------------+ +----------------+
                | -prompts: list of str | | -prompt: str   |
                |                       | | -response: str |
                | +get_prompt(): str    | | -date: str     |
                +-----------------------+ +----------------+
              
        +---------+-----+ +-----+---------+     +------------+
        |   SaveToFile  | |  LoadFromFile |     |  Display   |
        +----------------+ +----------------+   +-------------------------+
        | -filename: str | | -filename: str |   | -journal: list of Entry |
        |                | |                |   |                         |
        | +save(): None  | | +load(): None  |   | +display(): None        |
        +----------------+ +----------------+   +-------------------------+     
*/