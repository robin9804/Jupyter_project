import tensorflow as tf
import numpy as np
import matplotlib.pyplot as plt

from tensorflow.keras import layers

# tensorflow 로 구현하는 간단한 linear regression
def linearRegression():
    model = tf.keras.Sequential([
        layers.Dense(64, activation='relu', input_shape=[10]),
        layers.Dense(64, activation='relu'),
        layers.Dense(1)])
    optimizer = tf.keras.optimizers.RMSprop(0.001)
    
    model.compile(loss='mse', optimizer=optimizer, metrics=['mae', 'mse'])
    
    return model

lire = linearRegression()
lire.summary()

# 이걸로 simple regression이 가능하다고? 
# 선형회귀의 경우, 가장 간단한 모델로 구성해도 충분히 성능을 낼 수 있다.

# 64개의 노드로 구성된 완전연결층을 구현하여 linear regression 정도는 할 수 있다. optimizer를 adam으로 해도 된다는 사실
