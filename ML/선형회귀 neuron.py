# need import matplotlib and numpy

class Neuron:
    def __init__(self):
        self.w = 1.0
        self.b = 1.0 # weight and bias initiallize to 1.0

    def forpass(self, x):
        """
        calculate Forward prediction
        """
        y_hat = self.w * x + self.b
        return y_hat

    def backprop(self, x, err):
        """
        calculate back propagation about weight and bias gradient
        """
        w_grad = x*err
        b_grad = 1*err
        return w_grad, b_grad

    def fit(self, x_data, y_data, epochs = 100):
        """
        Training methode for ephochs
        """
        for i in range(epochs):
            for x, y in zip(x_data,y_data):
                y_hat = self.forpass(x)
                err = -(y-y_hat)
                w_grad, b_grad = self.backprop(x,err)
                self.w -= w_grad
                self.b -= b_grad



