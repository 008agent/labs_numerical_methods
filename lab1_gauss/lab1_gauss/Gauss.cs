using System;

    /// <summary>
    /// Класс содержит методы, алгоритмы для решения СЛАУ методом Гаусса.
    /// Класс сериализуем.
    /// </summary>
    [Serializable]
    public class Gauss
    {
//##########################КЛАССЫ ОШИБОК############################################
//###################################################################################
        //класс ошибки неинициализированного класса                                // 
        class GaussNotInitializedException : Exception                             //
        {                                                                          //  
            public override string Message
            {
                get
                {
                    return "Неинициализирован экземпляр класса.";
                }
            }                                      //
        }                                                                          //
        //класс ошибки неверной размерности                                        //
        class GaussIncorrectSizeException : Exception                              //
        {                                                                          //
            public override string Message
            {
                get
                {
                    return "Задана неверная размерность матрицы.";
                }
            }                                      //
        }                                                                          //
        //класс ошибки аналогичный IndexOutOfBounds                                //
        class GaussIndexOutOfRangeException : Exception                            //
        {                                                                          //     
            public override string Message
            {
                get
                {
                    return "Выход за пределы допустимого диапазона индекса";
                }
            }                                      //
        }                                                                          //
//###################################################################################
//##########################КЛАССЫ ОШИБОК############################################


        //внутренние поля. размерность, сама матрица, свободные члены.
        uint        szMatrix;
        double[,]   matrix;
        bool        SZinitialized       = false;
        bool        MatrixInitialized   = false;
        bool        ClassInitialized    = false;
        //точность округления(знаков после запятой);
        int         precision           = 3;

        /// <summary>
        /// Свойство, возвращающее исходную матрицу
        /// </summary>
        public double[,] getMatrix 
        { 
            get {
                if (!this.MatrixInitialized) throw new GaussNotInitializedException();
                    return matrix; 
                } 
        }

        /// <summary>
        /// Свойство, возвращающее размерность матрицы
        /// </summary>
        public uint getSize
        {
            get
            {
                if (!this.SZinitialized)
                {
                    throw new GaussNotInitializedException();
                }
                return this.szMatrix;
            }
        }
        /// <summary>
        /// Конструктор, принимающий параметр размерности
        /// </summary>
        /// <param name="size">Задает размерность матрицы</param>
        public Gauss(uint size)
        {
            if (size == 0)
            {
                throw new GaussIncorrectSizeException();
            }
            else
            {
                this.szMatrix = size;
                this.SZinitialized = true;
                this.ClassInitialized = (this.SZinitialized) && (this.MatrixInitialized);
            }
        }

        /// <summary>
        /// Конструктор, принимающий параметр размерности и исходной матрицы
        /// </summary>
        /// <param name="source">Задает исходную матрицу</param>
        /// <param name="size">Задает размерность матрицы</param>
        public Gauss(double[,] source, uint size)
        {
            if (size == 0)
            {
                throw new GaussIncorrectSizeException();
            }
            else
            {
                this.szMatrix = size;
                this.matrix = source;
                this.ClassInitialized = this.SZinitialized = this.MatrixInitialized = true;
            }
        }
        /// <summary>
        /// Задает новую размерность матрицы
        /// </summary>
        /// <param name="size"></param>
        public void set_new_size(uint size)
        {
            if (size == 0)
            {
                throw new GaussIncorrectSizeException();
            }
            else
            {
                this.szMatrix = size;
                this.ClassInitialized = (this.SZinitialized) && (this.MatrixInitialized);
            }
        }

        /// <summary>
        /// Задает элемент в матрице
        /// </summary>
        /// <param name="row">Номер элемента в строке</param>
        /// <param name="column">Номер элемента в столбце</param>
        /// <param name="element">Значение присваиваемого элемента</param>
        public void set_element(uint row, uint column, double element)
        {
            if (!this.MatrixInitialized)
            {
                throw new GaussNotInitializedException();
            }
            else
            {
                this.matrix[row, column] = element;
            }
        }

        /// <summary>
        /// Инициализирует матрицу нулями.
        /// Если матрица уже инициализирована, будет заполнена нулями.
        /// Если не инициализирована, будет выделена память заполнена нулями
        /// </summary>
        public void init_matrix()
        {
            //если размерность неинициализирована, выбросится исключение
            if (!this.SZinitialized)
            {
                throw new GaussNotInitializedException();
            }
            //если матрица не инициализирована, выделяем память
            if (!this.MatrixInitialized)
            {
                this.matrix = new double[this.szMatrix, this.szMatrix + 1];
            }
            //и в конце заполняем нулями
            {
                //строки
                for (uint i = 0; i<this.szMatrix; i++)
                {
                    //столбцы
                    for (uint j = 0; j < this.szMatrix + 1; j++)
                    {
                        this.matrix[i, j] = 0.0;
                    }
                }
            }
            this.MatrixInitialized = true;
            this.ClassInitialized = (this.SZinitialized) && (this.MatrixInitialized);

        }

        /// <summary>
        /// Инициализирует(если не инициализирована) и заполняет матрицу случайными числами
        /// </summary>
        /// <param name="startSeed"></param>
        /// <param name="endSeed"></param>
        public void init_matrix_randoms(int startSeed, int endSeed)
        {
            Random rnd = new Random();
            
            this.init_matrix();
            {
                //строки
                for (uint i = 0; i < this.szMatrix; i++)
                {
                    //столбцы
                    for (uint j = 0; j < this.szMatrix + 1; j++)
                    {
                        this.matrix[i, j] = Math.Round( (rnd.Next(startSeed, endSeed) * rnd.NextDouble()), this.precision );
                    }
                }
            }
        }


    }

